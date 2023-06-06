import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AppConsts } from '@shared/AppConsts';
import { map } from 'rxjs';

@Injectable()
export class StateService {
  baseUrl = AppConsts.remoteServiceBaseUrl;
  constructor(
    private http: HttpClient
  ) { }
  addState(State: string) {
    return this.http.post(
      `${this.baseUrl}/api/services/app/StateService/Create`, {
      name: State
    }
    ).pipe(map((data: any) => data.result));
  }

  updateState(id: number, state: string) {
    return this.http.put(
      `${this.baseUrl}/api/services/app/StateService/update?id=${id}`, {
      name: state
    }
    );
  }

  getState(id: number) {
    return this.http.get(
      `${this.baseUrl}/api/services/app/StateService/get?id=${id}`
    ).pipe(map((data: any) => data.result));
  }

  getStates(keyword: string = "", IsActive: boolean = true, skipCount: number = 0, maxResultCount: number = 100) {
    return this.http.get(
      `${this.baseUrl}/api/services/app/StateService/getAll`
    ).pipe(map((data: any) => data.result));
  }

  deleteState(id: number) {
    return this.http.delete(
      `${this.baseUrl}/api/services/app/StateService/delete?id=${id}`
    ).pipe(map((data: any) => data.result));
  }

}
