import { Component, OnInit } from '@angular/core';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-main-donation-program',
  templateUrl: './main-donation-program.component.html',
  styleUrls: ['./main-donation-program.component.css'],
})
export class MainDonationProgramComponent implements OnInit {
  breakpoints = {
    360: { slidesPerView: 1, spaceBetween: 20 },
    768: { slidesPerView: 2, spaceBetween: 40 },
    1024: { slidesPerView: 3, spaceBetween: 50 },
  };

  constructor(private donationProgramService: DonationProgramService) {}
  allDonationProgram?: DonationProgramModel[];

  ngOnInit(): void {
    this.donationProgramService.getAllDonationProgram("Đang quyên góp").subscribe({
      next: (response) => {
        this.allDonationProgram = response;
      },
    });
  }
}
