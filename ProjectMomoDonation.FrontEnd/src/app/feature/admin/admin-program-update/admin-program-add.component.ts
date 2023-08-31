import { Component, OnInit } from '@angular/core';
import { ProgramCreateModel } from '../../user/model/program-create.model';
import { AdminService } from '../admin.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DonationProgramService } from '../../user/services/donation-program-service.service';
import * as ClassicEditor from '@ckeditor/ckeditor5-build-classic';
import { ChangeEvent } from '@ckeditor/ckeditor5-angular';
import { ActivatedRoute } from '@angular/router';
import { DonationProgramModel } from '../../user/model/donation-program.model';

@Component({
  selector: 'app-admin-program-add',
  templateUrl: './admin-program-add.component.html',
  styleUrls: ['./admin-program-add.component.css'],
})
export class AdminProgramUpdateComponent implements OnInit {
  model: DonationProgramModel; // Initialize the model
  categoryListName: string[];
  organizationListName: string[];
  public Editor = ClassicEditor;
  story: string;
  id: string;
  constructor(
    private adminService: AdminService,
    private userService: DonationProgramService,
    private snackBar: MatSnackBar,
    private route: ActivatedRoute
  ) {}
  ngOnInit(): void {
    this.userService.getAllCategory().subscribe((categories) => {
      this.categoryListName = categories.map((category) => category.name);
    });
    this.userService
      .getAllOrganizationFundraise()
      .subscribe((organizations) => {
        this.organizationListName = organizations.map(
          (organization) => organization.name
        );
      });
    this.route.paramMap.subscribe((params) => {
      this.id = params.get('id');
    });
    this.adminService.getProgramById(this.id).subscribe((response) => {
      this.model = response;
      this.story = this.model.story;

      this.model.dateEnd.slice(0, 9);
    });
  }

  onModelUpdating() {
    this.adminService.updateProgram(this.id, this.model).subscribe({
      next: (response) => {
        // Display success message
        this.snackBar.open(`Cập nhật thành công`, 'Đóng', {
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
      },
    });
  }
  public onChange({ editor }: ChangeEvent) {
    this.model.story = editor.data.get();
  }
}
