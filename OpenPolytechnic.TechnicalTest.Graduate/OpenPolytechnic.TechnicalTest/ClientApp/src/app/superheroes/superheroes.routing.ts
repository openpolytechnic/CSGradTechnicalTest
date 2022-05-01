import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { MarvelSuperheroesComponent } from "./marvel/marvel.component";
import { SuperheroesComponent } from "./superheroes.component";

const routes: Routes = [
  {
    path: '',
    component: SuperheroesComponent,
    children: [
      {
        path: 'marvel',
        component: MarvelSuperheroesComponent
      }
    ],
  },
  {
    path: '**',
    pathMatch: 'full',
    redirectTo: '/'
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SuperheroesRouterModule { }
