   M S B A M L   `   `   `  ����F  BTestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TestProjectTestProject  5   	       TestProject.TovarClient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TestProject     5   	     � Title$  Товары��5   	   $	��450��6   $	��700��6%    � Icon$� �C:\Users\natal\Downloads\2 задания\2 задания\2 задание (маленькое с прошлого ДЭ)\Вариант 5\Общие ресурсы\icon.ico��61   .��5	      � .+�5
   
   �� $��Товары��6   $��Center=�6!   $	��Top=�6>   $��Times New Roman)�6V   $��24(�6s   6�   �� 5   
   -   5        $��	UserNames��5      $
��Left=�6!   $	��Top=�6<   $
��User��6T   $��Times New Roman)�6c   $��16(�6�   $��10,5,0,0q�6�   $��97��6�   �� 5   
   $
��Left=�6   $	��Top=�6+   $	��100��6C   $	��100��6O   $��10,29q�6\   $����C:\Users\natal\Downloads\2 задания\2 задания\2 задание (маленькое с прошлого ДЭ)\Вариант 5\Общие ресурсы\logo.png��6k   6�   �� 5   
   -   5        $��Вернуться��5      $
��Left=�6%   $��
564,10,0,0q�6@   $	��Top=�6T   $��94��6l   ���	#FFBF2525���	#FFB92121
�������$��Times New Roman)�6�   $��16(�6�   6�   �� 5   
   -   5        $��	btn_order��5      $��
Заказ��6"   $
��Left=�62   $��
564,37,0,0q�6M   $	��Top=�6a   $��94��6y   ���	#FFBF2525���	#FFB92121
�������$��Times New Roman)�6�   $��16(�6�   $y�Hidden=�6�   6  �� 5   
   $��	0,135,0,0q�6   $��Hidden=�6*   .��5      ��  �� Orientation$ 
Horizontal=�6   $	��274��62   .+�5      �� -   5        $��	ListTovar��5      
������ 
������ ��5      �� 5      .R�5      �� 
���   �
�������$	��650��6R   .��5   "   �� $ 
Horizontal=�6-   .+�5   &   ��  ��Name$ StringImage��60   $y�Hidden=�6E   ��6Y   �� *Photo+ �� StringFormat$ ../Test/{0}��6�   �� 5   &   $	��150��6]   $
��Left=�6i   $��5q�6�   ��6,   �� *Text+ �� ElementName$ StringImage��6�   �� 5   &   $ Vertical=�61   $��20 30q�6H   $	��400��6W   .+�5   *   �� $��ProductName��6J   ��64   �� *Name+6_   �� 5   *   $��ArticulName��6M   ��64   �� *	Articul+6b   �� 5   *   $��Descrip��6Q   $
��Wrap=�6`   ��64   �� *Description+6v   �� 5   *   $ 
Horizontal=�65   .+�5   .   �� $"��Производитель: ��68   6Q   �� 5   .   $��ManufacturProduct��6V   ��68   �� *Manufacturer+6q   5    +   �� 5!   *   $ 
Horizontal=�65   .+�5"   .   �� $��
Цена: ��68   6H   �� 5#   .   $��CostProduct��6N   ��68   �� *Cost+6c   5$   +   �� 5%   *   $ 
Horizontal=�65   .+�5&   .   �� $��Количество: ��68   6N   �� 5'   .   $��Kolvo��6Y   ��68   �� *QuantityInStock+6h   5(   +   �� 5)   *   $ 
Horizontal=�65   .+�5*   .   �� $��btn_Menu��65   -   5        $$��Добавить в заказ��5*   E   ���	#FFA01414���	#FFA61111
�������$��Times New Roman)�6�   6�   �� 5+   .   $��TovarID��6h   $y�Hidden=�6T   ��68   �� *
ID_Product+6h   5,   +   5-   '   5.   #   5/      50      52      53      54      55      56      