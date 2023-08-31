import { Component, OnInit } from '@angular/core';
import { OrganizationCreateModel } from '../../user/model/organization-create.model';
import { AdminService } from '../admin.service';
import { ActivatedRoute, Router } from '@angular/router';
import { OrganizationFundraiseModel } from '../../user/model/organization-fundraise.model';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-admin-organization-add',
  templateUrl: './admin-organization-add.component.html',
  styleUrls: ['./admin-organization-add.component.css']
})
export class AdminOrganizationUpdateComponent implements OnInit {
  model: OrganizationCreateModel // Initialize the model
  getModel : OrganizationFundraiseModel
  id : string;
  constructor(private adminService: AdminService,private route : ActivatedRoute, private router : Router, private snackBar : MatSnackBar) {
    
  }
  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.id = params.get('id');
      console.log(this.id)
    });
    this.adminService.getOrganizationById(this.id)
    .subscribe({
      next: (response) => {
        this.getModel=response;
        this.model = {
          name: this.getModel.name,
          shortName: this.getModel.shortName,
          description: this.getModel.description,
          avatar: this.getModel.avatar,
          image: this.getModel.image,
          urlSlug: this.getModel.urlSlug
        };
        console.log(this.model)
      }
    })
  }

  onModelUpdating() {

    this.adminService.updateNewOrganization(this.id,this.model)
      .subscribe({
        next: (response) => {
          this.snackBar.open(`Cập nhật thành công`, 'Đóng', {
            duration: 4000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
            }); 
        },
        error: (error) => {
          this.snackBar.open(`Có lỗi xảy ra. Vui lòng thử lại`, 'Đóng', {
            duration: 4000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
            }); 
          console.error('Error creating organization:', error);
        }
      });
  
  }
}
