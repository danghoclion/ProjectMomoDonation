import { Component, OnInit, ViewChild } from '@angular/core';
import { AdminService } from '../admin.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { UserModel } from '../../user/model/user.model';
import { UserManageModel } from '../../user/model/user-manage.model';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-admin-user-index',
  templateUrl: './admin-user-index.component.html',
  styleUrls: ['./admin-user-index.component.css'],
})
export class AdminUserIndexComponent implements OnInit {
  userList: UserManageModel[];
  displayedColumns = ['id', 'username', 'status'];
  @ViewChild('paginator', { static: true }) paginator: MatPaginator;
  dataSource: MatTableDataSource<UserManageModel>;
  constructor(private service: AdminService, private snackBar: MatSnackBar) {}
  ngOnInit(): void {
    this.service.getAllUser().subscribe({
      next: (response) => {
        this.userList = response;
        this.dataSource = new MatTableDataSource(this.userList);
        this.dataSource.paginator = this.paginator;
      },
    });
  }
  SetUserStatus(username: string, status: string) {
    this.service.setUserStatus(username, status).subscribe({
      next: () => {
        this.snackBar.open(`Cập nhật thành công`, 'Đóng', {
          duration: 2000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });
      },
    });
  }
  //User searching
  userSearch: string;
  searchResult: UserManageModel[];
  userSearching() {
    this.searchResult = this.userList;
    if (this.userSearch) {
      this.searchResult = this.searchResult.filter((user) => {
       return user.userName.toLowerCase().includes(this.userSearch.toLowerCase());
      });
    }
    console.log(this.searchResult)
    this.dataSource = new MatTableDataSource(this.searchResult);
    this.dataSource.paginator = this.paginator;
  }
}
