# How-to-implement-a-.NET-MAUI-Radial-Menu-in-a-listview
This sample explains how to implement a .NET MAUI Radial Menu in a listview


**XAML**
```
 <StackLayout>
 <syncfusion:SfListView x:Name="listView"  
             ItemsSource="{Binding BookInfo}"  ItemTapped="listView_ItemTapped_1" 
             ItemSize="250">

     <syncfusion:SfListView.ItemTemplate>
         <DataTemplate>
             <Grid x:Name="main">
                 <Grid.RowDefinitions>
                     <RowDefinition Height="0.4*" />
                     <RowDefinition Height="0.6*" />
                 </Grid.RowDefinitions>
                 <Label Text="{Binding BookName}" FontAttributes="Bold" TextColor="Teal" FontSize="Small" />
                 <Label Grid.Row="1" Text="{Binding BookDescription}" TextColor="Teal" FontSize="15"/>
             </Grid>
         </DataTemplate>
     </syncfusion:SfListView.ItemTemplate>
 </syncfusion:SfListView>


 <radialMenu:SfRadialMenu IsOpen="False" 
                          IsVisible="False"
                          Closing="radial_Menu_Closing_1"  
                          HeightRequest="250" 
                          WidthRequest="220"
                          x:Name="radial_Menu" 
                          CenterButtonText="&#xe710;"
                          CenterButtonFontFamily="MauiMaterialAssets" >
     <radialMenu:SfRadialMenu.Items>
             <radialMenu:SfRadialMenuItem Text="&#xe72e;" FontFamily="MauiMaterialAssets">
             <radialMenu:SfRadialMenuItem.Items>
                     <radialMenu:SfRadialMenuItem  Text="&#xe744;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe745;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe73b;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe762;" 
                     FontFamily="MauiMaterialAssets" />
             </radialMenu:SfRadialMenuItem.Items>
         </radialMenu:SfRadialMenuItem>
             <radialMenu:SfRadialMenuItem Text="&#xe72e;" 
             FontFamily="MauiMaterialAssets">
             <radialMenu:SfRadialMenuItem.Items>
                     <radialMenu:SfRadialMenuItem  Text="&#xe744;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe745;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe746;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe762;" 
                     FontFamily="MauiMaterialAssets" />
             </radialMenu:SfRadialMenuItem.Items>
         </radialMenu:SfRadialMenuItem>
             <radialMenu:SfRadialMenuItem  Text="&#xe72e;" 
             FontFamily="MauiMaterialAssets">
             <radialMenu:SfRadialMenuItem.Items>
                     <radialMenu:SfRadialMenuItem  Text="&#xe744;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe745;" 
                     FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe746;" 
                     FontFamily="MauiMaterialAssets" />
             </radialMenu:SfRadialMenuItem.Items>
         </radialMenu:SfRadialMenuItem>
             <radialMenu:SfRadialMenuItem  Text="&#xe710;" FontFamily="MauiMaterialAssets">
             <radialMenu:SfRadialMenuItem.Items>
                     <radialMenu:SfRadialMenuItem  FontSize="16" Text="&#xe744;" FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  FontSize="18" Text="&#xe745;" FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  FontSize="20" Text="&#xe746;" FontFamily="MauiMaterialAssets" />
             </radialMenu:SfRadialMenuItem.Items>
         </radialMenu:SfRadialMenuItem>
             <radialMenu:SfRadialMenuItem Text="&#xe710;" FontFamily="MauiMaterialAssets">
             <radialMenu:SfRadialMenuItem.Items>
                     <radialMenu:SfRadialMenuItem  Text="&#xe744;" FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe745;" FontFamily="MauiMaterialAssets" />
                     <radialMenu:SfRadialMenuItem  Text="&#xe746;" FontFamily="MauiMaterialAssets" />
             </radialMenu:SfRadialMenuItem.Items>
         </radialMenu:SfRadialMenuItem>
     </radialMenu:SfRadialMenu.Items>
 </radialMenu:SfRadialMenu>
  </StackLayout>
  ```

  **C#**
  ```
 private void listView_ItemTapped_1(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e) 
  {
      radial_Menu.TranslationX = e.Position.X - (radial_Menu.Width);
      radial_Menu.TranslationY = e.Position.Y - (radial_Menu.Height);
      radial_Menu.IsOpen = true;
      radial_Menu.IsVisible = true;
  }

  private void radial_Menu_Closing_1(object sender, Syncfusion.Maui.RadialMenu.ClosingEventArgs e) 
  {
      radial_Menu.IsVisible = false;
  }
  ```
