import { Component, OnInit } from '@angular/core';
import { ProgramCreateModel } from '../../user/model/program-create.model';
import { AdminService } from '../admin.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DonationProgramService } from '../../user/services/donation-program-service.service';
import * as ClassicEditor from '@ckeditor/ckeditor5-build-classic';
import { ChangeEvent } from '@ckeditor/ckeditor5-angular';

@Component({
  selector: 'app-admin-program-create',
  templateUrl: './admin-program-create.component.html',
  styleUrls: ['./admin-program-create.component.css']
})
export class AdminProgramCreateComponent implements OnInit {
  
  model: ProgramCreateModel // Initialize the model
  categoryListName : string[];
  organizationListName : string[];
  public Editor = ClassicEditor;
  story : string;

  constructor(private adminService: AdminService,private userService : DonationProgramService, private snackBar : MatSnackBar
    ) {
    this.model = {
      title: "string",
      avatarUrl: "string",
      urlSlug: "string",
      shortTitle: "string",
      story: "string",
      dateStart: "",
      dateEnd: "",
      totalDonate: 0,
      donationGoal: 0,
      categoryName: "string",
      organizationName: "string",

    };
    this.story = this.model.story
  }
  ngOnInit(): void {
    this.userService.getAllCategory().subscribe((categories) => {
      this.categoryListName = categories.map((category) => category.name);
    });
    this.userService.getAllOrganizationFundraise().subscribe((organizations) => {
      this.organizationListName = organizations.map((organization) => organization.name)
    })
  }

  onModelCreating() {

    this.adminService.createNewProgram(this.model)
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
  public onChange({ editor }: ChangeEvent) {
    this.model.story = editor.data.get();
  }
}
