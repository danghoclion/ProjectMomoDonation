export interface LoginResponseModel{
    status: string;
    name: string;
    jwtToken: string;
    roleName:string[];
}