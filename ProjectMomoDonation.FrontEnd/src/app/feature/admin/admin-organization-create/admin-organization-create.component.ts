import { Component } from '@angular/core';
import { AdminService } from '../admin.service';
import { OrganizationCreateModel } from '../../user/model/organization-create.model';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-admin-organization-create',
  templateUrl: './admin-organization-create.component.html',
  styleUrls: ['./admin-organization-create.component.css']
})
export class AdminOrganizationCreateComponent  {
  model: OrganizationCreateModel // Initialize the model
  constructor(private adminService: AdminService, private snackBar : MatSnackBar) {
    this.model = {
      name: "string",
      shortName: "string",
      description: "string",
      avatar: "string",
      image: "string",
      urlSlug: "string"
    };
  }

  onModelCreating() {

    this.adminService.createNewOrganization(this.model)
      .subscribe({
        next: (response) => {
                    // Display success message
                    this.snackBar.open(`Thêm mới thành công`, 'Đóng', {
                      duration: 2000,
                      horizontalPosition: 'center',
                      verticalPosition: 'top',
                      });  
        },
        error: (error) => {
                    // Display success message
                    this.snackBar.open(`Có lỗi xảy ra. Vui lòng thử lại sau`, 'Đóng', {
                      duration: 2000,
                      horizontalPosition: 'center',
                      verticalPosition: 'top',
                      });  
          console.error('Error creating organization:', error);
        }
      });
  }
}
