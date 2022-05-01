import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { SuperheroesService } from "../service/superheroes.service";
import { SuperheroesTableModule } from "../superheroes-table/superheroes-table.module";
import { MarvelSuperheroesComponent } from "./marvel.component";

@NgModule({
  imports: [
    CommonModule,
    SuperheroesTableModule
  ],
  declarations: [
    MarvelSuperheroesComponent
  ],
  providers: [
    SuperheroesService
  ],
  exports: [
    MarvelSuperheroesComponent
  ]
})
export class MarvelSuperheroesModule { }
