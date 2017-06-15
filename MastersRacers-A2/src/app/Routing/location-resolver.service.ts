import { Injectable } from '@angular/core';
import { Router, Resolve, RouterStateSnapshot,
         ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';

import { LocationModel } from '../Locations/location.type';

import { LocationService } from '../Services/location.service';
import { ErrorService } from '../Shared/error.service';
import { LoggerService } from '../Shared/logger.service';

@Injectable()
export class LocationResolver implements Resolve<LocationModel> {

    constructor (private ls: LocationService,
                 private router: Router,
                 private logger: LoggerService,
                 private error: ErrorService) {}

    resolve( route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<LocationModel> {

        const id: string = route.params['id'];
        const locationList = route.parent.data.locationList;

        let returnSeason: LocationModel = locationList.find( x => x.id === id);

        return Observable.of(returnSeason);
    }
}
