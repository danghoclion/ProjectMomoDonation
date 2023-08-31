import { Component, OnInit } from '@angular/core';
import { CategoryModel } from 'src/app/feature/user/model/category.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';
@Component({
  selector: 'app-hcqg-category-filter',
  templateUrl: './hcqg-category-filter.component.html',
  styleUrls: ['./hcqg-category-filter.component.css'],
})
export class HcqgCategoryFilterComponent implements OnInit {
  breakpoints = {
    360: { slidesPerView: 3, spaceBetween: 20 },
    768: { slidesPerView: 4, spaceBetween: 30 },
    1024: { slidesPerView: 6, spaceBetween: 40 },
  };
  constructor(private donationProgramService: DonationProgramService) {}

  allCategory?: CategoryModel[];
  ngOnInit(): void {
    this.donationProgramService.getAllCategory().subscribe({
      next: (response) => {
        this.allCategory = response;
      },
    });
  }
}
