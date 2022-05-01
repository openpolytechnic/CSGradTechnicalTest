import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { SuperheroesTableComponent } from "./superheroes-table.component";

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    SuperheroesTableComponent
  ],
  exports: [
    SuperheroesTableComponent
  ]
})
export class SuperheroesTableModule { }
