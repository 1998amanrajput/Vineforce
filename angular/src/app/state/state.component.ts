import { Component, OnDestroy, OnInit } from '@angular/core';
import { PageResponse } from '@shared/models/PageResponse.model';
import { StateService } from '@shared/state/state.service';
import { State } from '@shared/state/models/state.model';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-state',
  templateUrl: './state.component.html',
  styleUrls: ['./state.component.css']
})
export class StateComponent implements OnInit, OnDestroy {
  subscriptions: Subscription[] = [];
  stateResponse: PageResponse<State> = new PageResponse<State>();
  constructor(
    private stateService: StateService
  ) { }
  ngOnDestroy(): void {
    this.subscriptions.forEach(subscription => subscription.unsubscribe());
  }
  ngOnInit() {
    this.getStates();
  }

  getStates() {
    this.subscriptions.push
      (this.stateService.getStates().subscribe({
        next: (data) => {
          this.stateResponse = data;
        }
      }));
  }

  addState(stateName: string) {
    this.subscriptions.push
      (this.stateService.addState(stateName).subscribe());
  }

  updateState(id: number, stateName: string) {
    this.subscriptions.push
      (
        this.stateService.updateState(id, stateName).subscribe());
  }

  deleteState(id) {
    this.subscriptions.push
      (
        this.stateService.deleteState(id).subscribe());
  }
}
