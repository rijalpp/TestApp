import { Component, OnInit } from '@angular/core';
import { VehicleService } from './Shared/Services/vehicle.service';
import { Vehicle } from './Shared/Models/vehicle.model';
import { debug } from 'util';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Vehicle Application';
  constructor(private vehicleService: VehicleService) { }
  apiValues: Vehicle[] = [];
  
  ngOnInit() {
    this.vehicleService.getVehicles()
      .subscribe((data: Vehicle[]) => {
        this.apiValues = data;
      });
  };
};

