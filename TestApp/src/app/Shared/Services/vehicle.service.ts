import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';


@Injectable({ providedIn:'root' })
export class VehicleService {
  constructor(private httpService: HttpClient) { }
 
  getVehicles() {
    return this.httpService.get('api/vehicle');
  }
}

