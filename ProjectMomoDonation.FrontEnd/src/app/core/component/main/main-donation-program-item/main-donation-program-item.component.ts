import { Component, Input, OnInit } from '@angular/core';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';

@Component({
  selector: 'app-main-donation-program-item',
  templateUrl: './main-donation-program-item.component.html',
  styleUrls: ['./main-donation-program-item.component.css'],
})
export class MainDonationProgramItemComponent implements OnInit {
  @Input() donationProgram: DonationProgramModel;
  daysLeft: number;
  progressWidth: string;
  ngOnInit(): void {
    const dateEnd = new Date(this.donationProgram.dateEnd);
    const dateStart = new Date(this.donationProgram.dateStart);

    const timeDiff = dateEnd.getTime() - new Date().getTime();
    this.daysLeft = Math.ceil(timeDiff / (1000 * 3600 * 24));

    const totalDonate = this.donationProgram.totalDonate;
    const goalDonate = this.donationProgram.donationGoal;
    this.progressWidth = ((totalDonate / goalDonate) * 100).toFixed(2) + '%';
  }
}
