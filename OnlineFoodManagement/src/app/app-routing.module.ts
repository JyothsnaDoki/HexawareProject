import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { SignupComponent } from './signup/signup.component';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { CustomerDashboardComponent } from './customer-dashboard/customer-dashboard.component'
import { ViewitemsComponent } from './viewitems/viewitems.component';
import { AboutComponent } from './about/about.component';
import { ContactusComponent } from './contactus/contactus.component';
import { MenuComponent } from './menu/menu.component';
import { EditProfileComponent } from './edit-profile/edit-profile.component';
import { ViewprofileComponent } from './viewprofile/viewprofile.component';
import { AdditemComponent } from './additem/additem.component';
import { AddcartComponent } from './addcart/addcart.component';
import { CreateitemComponent } from './createitem/createitem.component';






const routes: Routes = [

  {path:"",component:IndexComponent},
  {path:"login",component:LoginComponent},
  {path:"profile/:userId",component:ProfileComponent},
   {path:"signup",component:SignupComponent},
   {path:"customerDashboard",component:CustomerDashboardComponent},
   {path:"adminDashboard",component:AdminDashboardComponent},
   {path:"viewitems",component:ViewitemsComponent},
   {path:"about",component:AboutComponent},
   {path:"contactus",component:ContactusComponent},
   {path:"menu",component:MenuComponent},
   {path:"editProfile/:userId",component:EditProfileComponent},
   {path:"viewProfile",component:ViewprofileComponent},
   {path:"additem",component:AdditemComponent},
   {path:"addcart",component:AddcartComponent},
   {path:"createitem",component:CreateitemComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
