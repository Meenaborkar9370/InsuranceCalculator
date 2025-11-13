
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class PremiumService{
  private api = "http://localhost:5000/api/premium/calculate";
  constructor(private http:HttpClient){}
  calculatePremium(data:any){
    return this.http.post(this.api,data);
  }
}
