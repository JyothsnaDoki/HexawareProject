import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IndexComponent } from './index/index.component';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavbarComponent } from './navbar/navbar.component';
import { ProfileComponent } from './profile/profile.component';
import { AboutComponent } from './about/about.component';
import { MenuComponent } from './menu/menu.component';
import { SignupComponent } from './signup/signup.component';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { CustomerDashboardComponent } from './customer-dashboard/customer-dashboard.component';
import { ViewitemsComponent } from './viewitems/viewitems.component';
import { ContactusComponent } from './contactus/contactus.component';
import { EditProfileComponent } from './edit-profile/edit-profile.component';
import { ViewprofileComponent } from './viewprofile/viewprofile.component';
import { AdditemComponent } from './additem/additem.component';
import { AddcartComponent } from './addcart/addcart.component';
import { CreateitemComponent } from './createitem/createitem.component';
import { FilterPipe } from './filter.pipe';



@NgModule({
  declarations: [
    AppComponent,
    IndexComponent,
    LoginComponent,
    AboutComponent,
    NavbarComponent,
   
    ProfileComponent,
        MenuComponent,
        SignupComponent,
        AdminDashboardComponent,
        CustomerDashboardComponent,
        ViewitemsComponent,
        ContactusComponent,
        EditProfileComponent,
        ViewprofileComponent,
        AdditemComponent,
        AddcartComponent,
        CreateitemComponent,
        FilterPipe,
        
       
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,ReactiveFormsModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
