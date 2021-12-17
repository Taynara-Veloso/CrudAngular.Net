import { NgModule } from '@angular/core';
import { MatGridListModule } from '@angular/material/grid-list';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';

const MaterialComponents = [
  MatGridListModule,
  MatToolbarModule,
  MatIconModule,
]

@NgModule({
  imports: [
    MaterialComponents
  ],
  exports: [
    MaterialComponents
  ]
})
export class MaterialModule { }
