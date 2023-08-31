import { Component, OnInit } from '@angular/core';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-hcqg-donation-program',
  templateUrl: './hcqg-donation-program.component.html',
  styleUrls: ['./hcqg-donation-program.component.css'],
})
export class HcqgDonationProgramComponent implements OnInit {
  breakpoints = {
    360: { slidesPerView: 1, spaceBetween: 20 },
    768: { slidesPerView: 2, spaceBetween: 40 },
    1024: { slidesPerView: 3, spaceBetween: 50 },
  };

  grid = {
    rows: 3,
    fill: 'row',
  };
  constructor(
    private donationProgramService: DonationProgramService,
    private route: ActivatedRoute
  ) {}
  allDonationProgram?: DonationProgramModel[];

  category: string | null = null;

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.category = params.get('category');
      this.fetchDonationPrograms();
    });
  }

  fetchDonationPrograms() {
    this.donationProgramService
      .getAllDonationProgram('Đang quyên góp')
      .subscribe({
        next: (response) => {
          this.allDonationProgram = this.filterDonationPrograms(response);
        },
      });
  }

  filterDonationPrograms(
    donationPrograms: DonationProgramModel[]
  ): DonationProgramModel[] {
    if (this.category) {
      return donationPrograms.filter(
        (donationProgram) =>
          donationProgram.categoryId.toString() === this.category
      );
    } else {
      return donationPrograms;
    }
  }
  
   //Data Filtering
   titleSearch: string;
   filterResults = this.allDonationProgram
 
   DataFiltering() {
     this.filterResults =this.allDonationProgram; 
     if (this.titleSearch) {
       this.filterResults = this.filterResults.filter((program) =>
         program.title.toLowerCase().includes(this.titleSearch.toLowerCase())
       );
     }

   }
}
