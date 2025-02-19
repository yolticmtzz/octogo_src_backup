import { Component, EventEmitter, Injector, Input, OnInit, Output, ViewChild } from '@angular/core';
import { PermissionTreeComponent } from '@app/admin/shared/permission-tree.component';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { NgForm } from '@angular/forms';
import { AwbCostApproachListDto, AwbCostApproachServiceProxy, CreateOrUpdateAwbCostApproachInput } from '@shared/service-proxies/service-proxies';
import { ValidationServiceService } from '@app/admin/validation-service.service';

@Component({
  selector: 'app-create-or-edit-awb-cost-approach',
  templateUrl: './create-or-edit-awb-cost-approach.component.html',
  styleUrls: ['./create-or-edit-awb-cost-approach.component.css']
})
export class CreateOrEditAwbCostApproachComponent extends AppComponentBase {

  @ViewChild('createOrEditAwbCostApproach', { static: true }) modal: ModalDirective;
  @ViewChild('permissionTree') permissionTree: PermissionTreeComponent;
  @ViewChild('AwbCostApproachForm') awbCostApproachForm: NgForm;
  @Input() perAWBCostApproach: AwbCostApproachListDto[]
  @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();
  createAwbApproach: CreateOrUpdateAwbCostApproachInput = new CreateOrUpdateAwbCostApproachInput()

  AwbCostApproachComponent: any;

  active = false;
  saving = false;
  isEdit = false;
  vcApproachName='';
 
  constructor(injector: Injector, private _awbcostapproachservice: AwbCostApproachServiceProxy
    ,public _validationService: ValidationServiceService) {
    super(injector)
  }

  ngOnInit(): void {
  }
  
  show(inApproachid?: number): void {  
    if (inApproachid == undefined) {
      this.active = true;
      this.isEdit = false;
      this.modal.show();
    }
    else {
        this.active = true;
        this.isEdit = true;
        this._awbcostapproachservice.getPerAwbCostApproachForEdit(inApproachid).subscribe(response => {
        this.createAwbApproach.inApproachID = response.table[0].inApproachID;
        this.createAwbApproach.vcApproachName = response.table[0].vcApproachName;
        this.createAwbApproach.vcDescription = response.table[0].vcDescription;
        this.vcApproachName = response.table[0].vcApproachName;
        this.modal.show();
      })
    }
  }
  
  save(form: NgForm): void {
   
    let Duplicacy = this.perAWBCostApproach.filter((a) => a.vcApproachName.trim().toLowerCase() === this.createAwbApproach.vcApproachName.trim().toLowerCase() && a.inApproachID != this.createAwbApproach.inApproachID).length === 1;;
    if (Duplicacy) {
      return this.notify.warn(this.l('DuplicateRecord'));
    } 
    else if (this.createAwbApproach.inApproachID == null) {
      this.saving = true;
      this._awbcostapproachservice.createOrUpdateAwbCostType(this.createAwbApproach).subscribe(e => {
        this.saving = false;
        this.notify.info(this.l('SavedSuccessfully'));
        this.close(form)
        this.modalSave.emit(null);
      })
    } else {
      this.saving = true;
      this._awbcostapproachservice.createOrUpdateAwbCostType(this.createAwbApproach).subscribe(e => {
        this.saving = false;
        this.notify.info(this.l('UpdateAwbCostApproachMessage'));
        this.close(form)
        this.modalSave.emit(null);
      })
    }
  }
  onShown(): void {
    document.getElementById('vcApproachName').focus();;
  }

  close(form: NgForm): void {
    this.active = false;
    this.createAwbApproach.inApproachID = null;
    this.modal.hide();
    form.resetForm();
  }
}
