import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SeasonListComponent } from '../Seasons/seasonList.component';
import { SeasonDefaultComponent } from '../Seasons/seasonDefault.component';
import { SeasonDetailComponent } from '../Seasons/seasonDetail.component';
import { SeasonResolver } from '../Routing/season-resolver.service';

const routes: Routes = [
    {
        path: '', component: SeasonListComponent, 
        children: [
            { path: '', component: SeasonDefaultComponent },
            { path: 'detail/:id', component: SeasonDetailComponent, resolve: { detailSeason: SeasonResolver }}
        ]
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SeasonRoutingModule {}
