import { Component, OnInit, ViewChild } from '@angular/core';
import { AdminService } from '../admin.service';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { DonationProgramModel } from '../../user/model/donation-program.model';
import { MatSelectModule } from '@angular/material/select';
import { DonationProgramService } from '../../user/services/donation-program-service.service';
@Component({
  selector: 'app-admin-program-index',
  templateUrl: './admin-program-index.component.html',
  styleUrls: ['./admin-program-index.component.css'],
})
export class AdminProgramIndexComponent implements OnInit {
  constructor(
    private adminService: AdminService,
    private userService: DonationProgramService,
    private snackBar: MatSnackBar
  ) {}
  programList: DonationProgramModel[];
  @ViewChild('paginator', { static: true }) paginator: MatPaginator;
  dataSource: MatTableDataSource<DonationProgramModel>;
  displayedColumns = [
    'id',
    'shortTitle',
    'avatarUrl',
    'dateStart',
    'dateEnd',
    'totalDonate',
    'donationGoal',
    'status',
    'categoryName',
    'organizationName',
    'countDonation',
    'action',
  ];
  //Data Filtering
  titleSearch: string;
  statusSearch: string;
  organizationSearch: string;
  organizationListName: string[];
  filterResults: DonationProgramModel[];

  DataFiltering() {
    this.filterResults =this.programList;
    if (this.statusSearch) {
      this.filterResults = this.filterResults.filter(
        (program) => program.status === this.statusSearch
      );
    }

    if (this.titleSearch) {
      this.filterResults = this.filterResults.filter((program) =>
        program.title.toLowerCase().includes(this.titleSearch.toLowerCase())
      );
    }

    if (this.organizationSearch) {
      this.filterResults = this.filterResults.filter(
        (program) => program.organizationName === this.organizationSearch
      );
    }

    this.dataSource = new MatTableDataSource(this.filterResults);
    this.dataSource.paginator = this.paginator;
  }

  ngOnInit(): void {
    this.adminService.getAllProgram().subscribe({
      next: (response) => {
        this.userService
          .getAllOrganizationFundraise()
          .subscribe((organizations) => {
            this.organizationListName = organizations.map(
              (organization) => organization.name
            );
          });
        this.programList = response;
        this.dataSource = new MatTableDataSource(this.programList);
        this.dataSource.paginator = this.paginator;
      },
    });
  }

  OnChangeStatus(id: string, status: string) {
    this.adminService.updateStatus(id, status).subscribe({
      next: () => {
        this.snackBar.open(`Đã chuyển trạng thái thành ${status}`, '', {
          duration: 2000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });
        this.ngOnInit();
      },
    });
  }

  OnDelete(id: string) {
    this.adminService.deleteProgram(id).subscribe({
      next: (response) => {
        // You can perform any actions after successful deletion here
        this.snackBar.open(`Xoá thành công`, 'Đóng', {
          duration: 2000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });

        this.adminService.getAllProgram().subscribe({
          next: (response) => {
            this.programList = response;
            this.dataSource = new MatTableDataSource(this.programList);
            this.dataSource.paginator = this.paginator;
          },
        });
      },
      error: (error) => {
        // Handle error
        this.snackBar.open(`Có lỗi xảy ra. Vui lòng thử lại sau`, 'Đóng', {
          duration: 2000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });
        console.error('Error deleting organization', error);
      },
    });
  }
}
