import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HouseDetailComponent } from './house-detail/house-detail.component';
import { HouselistComponent } from './houselist/houselist.component';
import { HeaderComponent } from './header/header.component';
import { SearchformComponent } from './searchform/searchform.component';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

const appRoutes: Routes = [
    {path: 'house', component:HouselistComponent},
    {path: 'house/:id', component:HouseDetailComponent },
    {path: '', redirectTo: '/house', pathMatch: 'full'},
    {path: '**', redirectTo: '/house', pathMatch: 'full'}
]

@NgModule({
  declarations: [
    AppComponent,
    HouseDetailComponent,
    HouselistComponent,
    HeaderComponent,
    SearchformComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(
      appRoutes
    ),
    FormsModule,
    NgbModule // This is used to create a form
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
