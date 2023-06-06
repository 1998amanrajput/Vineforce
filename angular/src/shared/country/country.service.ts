import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {Country } from './models/country.model';
import {PageResponse } from '../models/PageResponse.model';
import { AppConsts } from '@shared/AppConsts';
import { map } from 'rxjs';

@Injectable()
export class CountryService {
  baseUrl = AppConsts.remoteServiceBaseUrl;
  constructor(
    private http: HttpClient
  ) { }
  addCountry(country: string) {
    return this.http.post(
      `${this.baseUrl}/api/services/app/CountryService/Create`, {
      name: country
    }
    ).pipe(map((data: any) => data.result));
  }

  updateCountry(id: number, country: string) {
    return this.http.put(
      `${this.baseUrl}/api/services/app/CountryService/update?id=${id}`, {
      name: country
    }
    ).pipe(map((data: any) => data.result));
  }

  getCountry(id: number) {
    return this.http.get(
      `${this.baseUrl}/api/services/app/CountryService/get?id=${id}`
    ).pipe(map((data: any) => data.result));
  }

  getCountries(keyword: string = "", IsActive: boolean = true, skipCount: number = 0, maxResultCount: number = 100) {
    return this.http.get<PageResponse<Country>>(
      `${this.baseUrl}/api/services/app/CountryService/getAll`
    ).pipe(map((data: any) => data.result));
  }

  deleteCountry(id: number) {
    return this.http.delete(
      `${this.baseUrl}/api/services/app/CountryService/delete?id=${id}`
    ).pipe(map((data: any) => data.result));
  }

}
