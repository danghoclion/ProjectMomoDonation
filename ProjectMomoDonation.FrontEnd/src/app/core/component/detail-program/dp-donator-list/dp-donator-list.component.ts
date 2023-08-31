import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { DonateHistoryModel } from 'src/app/feature/user/model/donate-history.model';
import { AccountService } from 'src/app/feature/user/services/account-service.service';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-dp-donator-list',
  templateUrl: './dp-donator-list.component.html',
  styleUrls: ['./dp-donator-list.component.css']
})
export class DpDonatorListComponent implements OnInit {
  constructor(private donationService : DonationProgramService){}
  @Input() urlSlug : string
  @ViewChild('paginator', { static: true }) paginator: MatPaginator;
  donateList : DonateHistoryModel[];
  displayedColumns =['username','amount','time']


  dataSource: MatTableDataSource<DonateHistoryModel>;
 
  
  ngOnInit(): void {
    this.donationService.getDonateListByUrlSlugProgram(this.urlSlug)
    .subscribe({
      next: (response) => {
        this.donateList = response;
        this.dataSource = new MatTableDataSource(this.donateList)
        this.dataSource.paginator = this.paginator
      }
    })
    
  }
  

}
