   M S B A M L   `   `   `  ����I  ETrabalhoCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TrabalhoCSharp.ViewTrabalhoCSharp.View  5      C&clr-namespace:TrabalhoCSharp.ViewModelTrabalhoCSharp.ViewModel  5      *    $TrabalhoCSharp.View.RegisterCategory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:TrabalhoCSharp.View     5      5vm&clr-namespace:TrabalhoCSharp.ViewModel     5        N� Title$  RegisterCategory��5
       � 	Resources 5      8  2TrabalhoCSharp.ViewModel.RegisterCategoryViewModel   RegisterCategoryViewModel��%   &	          5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $��1��6   $��1��6   .��6-   Nome:64   �� 5!   
   $��2��6   $��1��6   ��6/   ��  �� Source# [   �� Path$ Category.Name� �� Mode$ TwoWay=��� 5"   
   $��3��6   $��1��6   ��6.   �� # [  $ SaveCommand�.��6�   Salvar6�   5%      5'      