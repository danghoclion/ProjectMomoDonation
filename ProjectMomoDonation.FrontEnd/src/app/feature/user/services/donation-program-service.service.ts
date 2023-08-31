import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DonationProgramModel } from '../model/donation-program.model';
import { Observable } from 'rxjs';
import { OrganizationFundraiseModel } from '../model/organization-fundraise.model';
import { CategoryModel } from '../model/category.model';
import { DonateHistoryModel } from '../model/donate-history.model';
import { Environment } from '../environment';
import { PaymentResponsemodel } from '../model/payment-response.model';
import { DonateRequestModel } from '../model/donate-request.model';
import { DonateResponseModel } from '../model/donate-response.model';
import { DonationResponseQueryParams } from '../model/donate-response-query-params.model';
import { StatisticsModel } from '../model/statistic.model';
@Injectable({
  providedIn: 'root',
})
export class DonationProgramService {
  constructor(private http: HttpClient) {}

  getDonationProgramByUrlSlug(
    inputUrl: string
  ): Observable<DonationProgramModel> {
    return this.http.get<DonationProgramModel>(
      `https://localhost:7195/api/ProgramDonation?urlSlug=${inputUrl}`
    );
  }

  getAllDonationProgram(status:string): Observable<DonationProgramModel[]> {
    return this.http.get<DonationProgramModel[]>(
      `https://localhost:7195/api/ProgramDonation/filter?status=${status}`
    );
  }
  getAllOrganizationFundraise(): Observable<OrganizationFundraiseModel[]> {
    return this.http.get<OrganizationFundraiseModel[]>(
      `https://localhost:7195/api/OrganizationFundraise`
    );
  }
  getAllCategory(): Observable<CategoryModel[]> {
    return this.http.get<CategoryModel[]>(
      `https://localhost:7195/api/Categorys`
    );
  }
  getLastestProgtam(): Observable<DonationProgramModel[]> {
    return this.http.get<DonationProgramModel[]>(
      'https://localhost:7195/api/ProgramDonation/GetLastest?size=3'
    );
  }
  getOrganizationFundraiseById(
    id: string
  ): Observable<OrganizationFundraiseModel> {
    return this.http.get<OrganizationFundraiseModel>(
      `https://localhost:7195/api/OrganizationFundraise/${id}`
    );
  }
  getProgramListByOrganizationId(
    id: string
  ): Observable<DonationProgramModel[]> {
    status = "Đang quyên góp";
    return this.http.get<DonationProgramModel[]>(
      `https://localhost:7195/api/ProgramDonation/filter?organitionId=${id}&status=${status}`
    );
  }
  getDonateListByUsername(
    username : string
  ) : Observable<DonateHistoryModel[]>{
    return this.http.get<DonateHistoryModel[]>(
      `https://localhost:7195/api/DonateHistory/GetByUsername?userName=${username}`
    )
  }
  getDonateListByUrlSlugProgram(
    urlSlug : string
  ) : Observable<DonateHistoryModel[]>{
    return this.http.get<DonateHistoryModel[]>(
      `https://localhost:7195/api/DonateHistory/GetByUrlslugProgram?urlslug=${urlSlug}`
    )
  }

  //Donate service
  donateRequest(donateRequest : DonateRequestModel) : Observable<DonateResponseModel>{
    return this.http.post<DonateResponseModel>(
      `${Environment.apiBaseUrl}/api/Payment?money=${donateRequest.money}&userName=${donateRequest.userName}
      &programId=${donateRequest.programId}&urlRedirect=${donateRequest.urlRedirect}`,{}
    )
  }
  donateResponse(donateResponse : DonationResponseQueryParams) : Observable<void>{
    return this.http.post<void>(
      `${Environment.apiBaseUrl}/api/Payment/Response`,
      {
        partnerCode: donateResponse.partnerCode,
        orderId: donateResponse.orderId,
        requestId: donateResponse.requestId,
        amount: donateResponse.amount,
        orderInfo: donateResponse.orderInfo,
        orderType: donateResponse.orderType,
        transId: donateResponse.transId,
        resultCode: donateResponse.resultCode,
        message: donateResponse.message,
        payType: donateResponse.payType,
        responseTime: donateResponse.responseTime,
        extraData: donateResponse.extraData,
        signature: donateResponse.signature
      }
    )
  }
  //Statistic service
  getStatistic() : Observable<StatisticsModel>{
    return this.http.get<StatisticsModel>(
      `${Environment.apiBaseUrl}/api/Statistics/GetStatistic`
    )
  }
}
