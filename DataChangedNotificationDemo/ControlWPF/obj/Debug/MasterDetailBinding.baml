   M S B A M L   `   `   `  ����  
ControlWPF    ControlWPF.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  MasterDetailBinding��5      $	��300��5      $	��300��6   .��5      �� $��6q�6   .+�5   
   �� $��Categories:��6   �� 5	   
   -   5         ��Name$ cboCategories��5
       �� DisplayMemberPath$
 Name��5       �� SelectedIndex$ 0��5      ��5      �� 5      �� 5   
   $��	Products:��6   �� 5   
   -   5         ��Name$ lstProducts��5      $
 Name��5       �� SelectedValuePath$ ID��5      $ 0��5      ��5      ��  �� ElementName$ cboCategories�� �� Path$ SelectedItem.Products�5      �� 5   
   $��Details��6   $��5q�6$   .��5      �  � RowDefinitions 5      �� 5      �� 5      	 � ColumnDefinitions	 5      �� 5      �� 5      .+�5!      �� $��Product's ID��6   �� 5"      $��1��6   ��5#      �� $ lstProducts��$ SelectedValue��� 5$      $��Product's Name��6   $��1��62   �� 5%      $��1��6   $��1��6*   ��5&      �� $ lstProducts��$ SelectedItem.Name�5'      5(      5)      5*      