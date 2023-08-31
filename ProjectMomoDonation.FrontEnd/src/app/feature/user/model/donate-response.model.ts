export interface DonateResponseModel{
  partnerCode: string;
  orderId: string;
  requestId: string;
  amount: number;
  responseTime: number;
  message: number;
  resultCode: number;
  payUrl:string;
  deeplink: string;
  deeplinkMiniApp: string;
}