import { Component, OnInit } from '@angular/core';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';
@Component({
  selector: 'app-dtdh-lastest-post',
  templateUrl: './dtdh-lastest-post.component.html',
  styleUrls: ['./dtdh-lastest-post.component.css'],
})
export class DtdhLastestPostComponent {
  constructor(private donationProgramService: DonationProgramService) {}
  lastestDonationProgram?: DonationProgramModel[];
  loop: number[] = [];

  ngOnInit(): void {
    this.donationProgramService.getLastestProgtam().subscribe({
      next: (response) => {
        this.lastestDonationProgram = response;
      },
    });
  }
}
