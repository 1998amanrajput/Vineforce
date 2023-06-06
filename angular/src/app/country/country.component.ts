import { Component, OnDestroy, OnInit } from '@angular/core';
import { CountryService } from '@shared/country/country.service';
import { Country } from '@shared/country/models/country.model';
import { PageResponse } from '@shared/models/PageResponse.model';
import { Observable, Subscription, of } from 'rxjs';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.css']
})
export class CountryComponent implements OnInit, OnDestroy {
  countriesResponse: PageResponse<Country> = new PageResponse<Country>();
  subscriptions: Subscription[] = [];
  constructor(
    private countryService: CountryService
  ) { }

  ngOnDestroy(): void {
    this.subscriptions.forEach(subscription => subscription.unsubscribe());
  }

  ngOnInit() {
    this.getCountries();
  }

  getCountries() {
    this.subscriptions.push
      (
        this.countryService.getCountries().subscribe({
          next: (data) => {
            this.countriesResponse = data;
          }
        }));
  }

  addCountry(countryName: string) {
    this.subscriptions.push
      (this.countryService.addCountry(countryName).subscribe());
  }

  updateCountry(id: number, countryName: string) {
    this.subscriptions.push
      (this.countryService.updateCountry(id, countryName).subscribe());
  }

  deleteCountry(id) {
    this.subscriptions.push
      (this.countryService.deleteCountry(id).subscribe());
  }
}
