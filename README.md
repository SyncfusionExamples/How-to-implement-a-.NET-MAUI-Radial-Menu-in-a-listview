# How-to-implement-a-.NET-MAUI-Radial-Menu-in-a-listview
This sample explains how to implement a .NET MAUI Radial Menu in a listview


**XAML**
```
<StackLayout>
<syncfusion:SfListView x:Name="listView"  
                       ItemsSource="{Binding BookInfo}"  
                       ItemTapped="listView_ItemTapped" 
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
                         Closing="radialMenu_Closing"  
                         HeightRequest="250" 
                         WidthRequest="220"
                         x:Name="radialMenu" 
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
 private void listView_ItemTapped(object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e) 
 {
    radialMenu.TranslationX = e.Position.X - (radialMenu.Width);
    radialMenu.TranslationY = e.Position.Y - (radialMenu.Height);
    radialMenu.IsOpen = true;
    radialMenu.IsVisible = true;
 }

 private void radialMenu_Closing(object sender, Syncfusion.Maui.RadialMenu.ClosingEventArgs e)
 {
    radialMenu.IsVisible = false;
 }
  ```
## How to run this application?

To run this application, you need to first clone the How-to-implement-a-.NET-MAUI-Radial-Menu-in-a-listview repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
