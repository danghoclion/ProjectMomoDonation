import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { DonationResponseQueryParams } from 'src/app/feature/user/model/donate-response-query-params.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-dp-payment-response',
  templateUrl: './dp-payment-response.component.html',
  styleUrls: ['./dp-payment-response.component.css'],
})
export class DpPaymentResponseComponent implements OnInit {
  donateBack: DonationResponseQueryParams;
  returnUrl: string;

  constructor(
    private paymentService: DonationProgramService,
    private route: ActivatedRoute,
    private router: Router,
    private snackBar: MatSnackBar
  ) {}
  ngOnInit(): void {
    // Use ActivatedRoute to get all query parameters from the URL
    this.route.queryParams.subscribe((queryParams) => {
      console.log('All Query Parameters:', queryParams);

      // Create a DonateResponseModel object using the extracted query parameters
      this.donateBack = {
        partnerCode: queryParams.partnerCode,
        orderId: queryParams.orderId,
        requestId: queryParams.requestId,
        amount: parseFloat(queryParams.amount),
        orderInfo: queryParams.orderInfo,
        orderType: queryParams.orderType,
        transId: parseInt(queryParams.transId),
        resultCode: parseInt(queryParams.resultCode),
        message: queryParams.message,
        payType: queryParams.payType,
        responseTime: parseInt(queryParams.responseTime),
        extraData: queryParams.extraData,
        signature: queryParams.signature,
      };
      this.paymentService.donateResponse(this.donateBack).subscribe({
        next: () => {
          this.snackBar.open(`Quyên góp thành công`, 'Đóng', {
            duration: 2000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
          });
          //Redirect
          this.route.paramMap.subscribe((params) => {
            this.returnUrl = params.get('return-url');
            this.router.navigateByUrl(
              '/hoan-canh-quyen-gop/details/' + this.returnUrl
            );
          });
        },
        error: () => {
          this.snackBar.open(`Thanh toán thất bại`, 'Đóng', {
            duration: 2000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
          });
          //Redirect
          this.route.paramMap.subscribe((params) => {
            this.returnUrl = params.get('return-url');
            this.router.navigateByUrl(
              '/hoan-canh-quyen-gop/details/' + this.returnUrl
            );
          });
        },
      });
    });
  }
}
