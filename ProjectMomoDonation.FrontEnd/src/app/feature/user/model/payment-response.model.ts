export interface PaymentResponsemodel{
    partnerCode : string,
    orderId : string,
    requestId : string,
    amount: number,
    responseTime: number,
    message: string,
    resultCode:number,
    payUrl:string,
    deeplink: string,
    deeplinkMiniApp: string,
}