﻿using Data.Repositry;
using Domain.Repository;
using Domain.UseCase;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var userRepository = new UserRepository();
            UserUseCase userUseCase = new UserUseCase();
            userRepository.GetAuthUser(userUseCase);
        }
    }
}