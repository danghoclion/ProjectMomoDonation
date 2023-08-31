import { Component, OnInit, ViewChild } from '@angular/core';
import { AdminService } from '../admin.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OrganizationFundraiseModel } from '../../user/model/organization-fundraise.model';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-admin-organization-index',
  templateUrl: './admin-organization-index.component.html',
  styleUrls: ['./admin-organization-index.component.css'],
})
export class AdminOrganizationIndexComponent implements OnInit {
  constructor(
    private adminService: AdminService,
    private router: Router,
    private snackBar: MatSnackBar
  ) {}
  categoryList: OrganizationFundraiseModel[];
  @ViewChild('paginator', { static: true }) paginator: MatPaginator;
  dataSource: MatTableDataSource<OrganizationFundraiseModel>;
  displayedColumns = [
    'OrganizationFundraiseId',
    'urlSlug',
    'name',
    'shortName',
    'description',
    'avatar',
    'image',
    'action',
  ];
  ngOnInit(): void {
    this.adminService.getAllOrganization().subscribe({
      next: (response) => {
        this.categoryList = response;
        this.dataSource = new MatTableDataSource(this.categoryList);
        this.dataSource.paginator = this.paginator;
      },
    });
  }

  OnDelete(id: string) {
    // const index = this.categoryList.findIndex(item => item.organizationFundraiseId.toString() === id);
    //         console.log(index)
    //       if (index !== -1) {
    //         this.categoryList.splice(index, 1);
    //         this.dataSource = new MatTableDataSource(this.categoryList);
    //         this.dataSource.paginator = this.paginator
    //       }
    this.adminService.deleteOrganization(id).subscribe({
      next: (response) => {
        // You can perform any actions after successful deletion here
        this.snackBar.open(`Xoá thành công`, 'Đóng', {
          duration: 4000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });

        this.adminService.getAllOrganization().subscribe({
          next: (response) => {
            this.categoryList = response;
            this.dataSource = new MatTableDataSource(this.categoryList);
            this.dataSource.paginator = this.paginator;
          },
        });
      },
      error: (error) => {
        // Handle error
        this.snackBar.open(`Có lỗi xảy ra. Vui lòng thử lại sau`, 'Đóng', {
          duration: 4000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });
        console.error('Error deleting organization', error);
      },
    });
  }
}
