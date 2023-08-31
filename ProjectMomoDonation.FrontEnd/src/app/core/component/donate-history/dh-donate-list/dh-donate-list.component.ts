import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { DonateHistoryModel } from 'src/app/feature/user/model/donate-history.model';
import { UserModel } from 'src/app/feature/user/model/user.model';
import { AccountService } from 'src/app/feature/user/services/account-service.service';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-dh-donate-list',
  templateUrl: './dh-donate-list.component.html',
  styleUrls: ['./dh-donate-list.component.css']
})
export class DhDonateListComponent implements OnInit {

  constructor(private accountService : AccountService, private router : Router,private donationService : DonationProgramService){}

  donateList : DonateHistoryModel[];
  displayedColumns =['nameProgram','amount','time']
  @ViewChild('paginator', { static: true }) paginator: MatPaginator;
  user : UserModel;
  dataSource: MatTableDataSource<DonateHistoryModel>;
 
  
  ngOnInit(): void {
    this.accountService.user()
    .subscribe({
      next: (response) => {
        this.user=response;
      }
    })

    this.user = this.accountService.getUser();
    this.donationService.getDonateListByUsername(this.user.username)
    .subscribe({
      next: (response) => {
        
        this.donateList = response
        this.dataSource = new MatTableDataSource(this.donateList)
        this.dataSource.paginator = this.paginator;
        console.log(this.dataSource)
      }
    })
  }
}
