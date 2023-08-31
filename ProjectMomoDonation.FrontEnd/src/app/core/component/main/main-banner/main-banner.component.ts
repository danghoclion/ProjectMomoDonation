import { Component, OnInit } from '@angular/core';
import { StatisticsModel } from 'src/app/feature/user/model/statistic.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-main-banner',
  templateUrl: './main-banner.component.html',
  styleUrls: ['./main-banner.component.css'],
})
export class MainBannerComponent implements OnInit {
  statisticInformation : StatisticsModel
  constructor(private service : DonationProgramService){}
  ngOnInit(): void {
    this.service.getStatistic().subscribe({
      next: (response) => {
        this.statisticInformation = response;
      }
    })
  }

}
