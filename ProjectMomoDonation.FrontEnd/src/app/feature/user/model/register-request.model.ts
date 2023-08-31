export interface RegisterRequestModel{
    username: string,
    password: string,
    repassword:string,
    roles: string[],
    status: string
}