using DetskiySad.Data;
using DetskiySad.UserPages;
using System.Windows;

namespace DetskiySad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameApp.frmObj = Frm;

            DbConnect.entObj = new DetskiySadEntities();

            Frm.Navigate(new LoginPage());
        }

        /*
         * 
         * <Button Style="{StaticResource MenuButton} "
                    Margin="-100,20,10,0"
                    Content="Добавить воспитателя"
                    Name="AddTeacher"/>

            <Button Style="{StaticResource MenuButton} "
                    Margin="-100,20,10,0"
                    Content="Удалить воспитателя"
                    Name="DeleteTeacher"/>

        <Button Style="{StaticResource MenuButton} "
                    Margin="150,10,10,10"
                    Content="Добавить воспитаника"
                    Name="AddKid"/>
            
            <Button Style="{StaticResource MenuButton} "
                    Margin="150,10,10,10"
                    Content="Удалить воспитанника"
                    Name="DeleteKid"/>   
                 
         */

    }
}
