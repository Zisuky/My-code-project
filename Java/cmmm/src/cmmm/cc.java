package cmmm;

import java.sql.*;
import java.util.Scanner;

public class cc {
	Scanner sc = new Scanner(System.in);
//Xuat
	public void out(Statement cmd) {
		try {
		String cl = "SELECT * FROM SINHVIEN";//lenh truy van
		   ResultSet rs = cmd.executeQuery(cl);//thuc hien lenh truy van
		   System.out.printf("%55s\n","LIST OF STUDENTS");
		   System.out.printf("%-15s%-20s%-20s%-25s%-10s\n", "MSV", "Ho ten", "Ten", "Gioi tinh", "Ngay sinh", "CMMMMMMMMM");
		   while (rs.next()) {
			   System.out.printf("%-15s%-20s%-20s%-25s%-10s\n",
					rs.getString("MASV"), 
         		rs.getString("HOSV"),
         		rs.getString("TENSV"),
         		rs.getString("PHAI"),
         		rs.getString("NS"),
         		rs.getString("MAKHOA")
         		);
			   		}
		   } catch (SQLException e) {
						System.out.println("Truy vấn thất bại!");
						e.printStackTrace();
					}
}
	
	
//them	
	public void add(Connection cnn) {
	    try {
	        
	        System.out.println("Input number of students for insertion: ");
	        int soluong = sc.nextInt();
	        sc.nextLine(); //doc dong moi

	        for (int i = 1; i <= soluong; i++) {
	            PreparedStatement add = cnn.prepareStatement("INSERT INTO SINHVIEN(MASV,HOSV,TENSV,NS,PHAI,MAKHOA,) "
	                    									+ "VALUES(?,?,?,?,?,?)");

	            System.out.println("MASV: ");
	            add.setString(1, sc.nextLine());

	            System.out.println("Ho cua SV: ");
	            add.setString(2, sc.nextLine());

	            System.out.println("Ten cua SV: ");
	            add.setString(3, sc.nextLine());

	            System.out.println("Ngay Sinh: ");
	            add.setString(4, sc.nextLine());

	            System.out.println("Gioi Tinh: ");
	            add.setString(5, sc.nextLine());

	            System.out.println("Ma Khoa: ");
	            add.setString(6, sc.nextLine());

	            add.executeUpdate();

	            System.out.println("Them thanh cong sinh vien thu " + i);
	        }
	    } catch (SQLException e) {
	        System.out.println("Them that bai!");
	        e.printStackTrace();
	    }
}
	
	
//timkiem
	public void search(Connection cnn) {
		try {
		 System.out.println("Input MASV for Search: ");
		   System.out.println("MASV: ");
		   PreparedStatement sr = cnn.prepareStatement("SELECT * FROM SINHVIEN WHERE MASV = ?");
		   sr.setString(1,sc.nextLine());
		   ResultSet result = sr.executeQuery();
		   boolean dataExists = false;
		   	if(result.next()) {
		   		dataExists = true;
			  System.out.printf("%-15s%-20s%-20s%-25s%-10s\n", "MSV",
					                                           "Ho ten",
					                                           "Ten",
					                                           "Gioi tinh",
					                                           "Ngay sinh",
					                                           "Ma khoa");
		   	  System.out.printf("%-15s%-20s%-20s%-25s%-10s\n", result.getString("MASV"), 
		   			result.getString("HOSV"),
		   			result.getString("TENSV"),
		   			result.getString("PHAI"),
		   			result.getString("NS"),
		   			result.getString("MAKHOA"));
				   		}

          if (!dataExists) {
              System.out.println("Not found MASV!");
          }
		} catch (SQLException e) {
			System.out.println("Tìm kiếm thất bại!");
			e.printStackTrace();
		} 
}
	
	
//xoa
	public void delete(Connection cnn) {
	   try {
		 System.out.println("Input MASV of student for Delete: ");
		   System.out.println("MASV: ");
		   PreparedStatement sl = cnn.prepareStatement("SELECT * FROM SINHVIEN WHERE MASV = ?");
		   String input = sc.nextLine();
		   sl.setString(1, input);
		   
		   ResultSet result1 = sl.executeQuery();
		   boolean dataExists1 = false;
		   
		   if(result1.next()) {
		   		dataExists1 = true;
		   PreparedStatement dl = cnn.prepareStatement("DELETE FROM SINHVIEN WHERE MASV =?");
		   dl.setString(1, input);
		
		   dl.executeUpdate();
		   System.out.println("Successful Delete!");
		   	}
		    if (!dataExists1) {
              System.out.println("Not found MASV!");
          }
	  } catch (SQLException e) {
		System.out.println("Xóa thất bại!");
		e.printStackTrace();
	}
}
	
	
//cap nhat	
	public void update(Connection cnn) {
		try {
		PreparedStatement checkExist = cnn.prepareStatement("SELECT * FROM SINHVIEN WHERE MASV = ?");
		   System.out.println("Input MASV for CHECK: ");
		   String masv = sc.nextLine();
		   checkExist.setString(1, masv);
		   ResultSet exist = checkExist.executeQuery();
		   
		   if (exist.next()) {
		   System.out.println("Exist!");
		   System.out.println("Input information of student for update: ");
		   PreparedStatement ud = cnn.prepareStatement("UPDATE SINHVIEN SET HOSV =?,"
		   		                                    + " TENSV = ?,"
		   		                                    + " NS = ?,"
		   		                                    + "PHAI = ?,"
		   		                                    + " MAKHOA =?"
		   		                                    + " WHERE MASV = ?");		
		   System.out.println("Ho cua SV: ");
			ud.setString(1, sc.nextLine());
		   System.out.println("Ten cua SV: ");
			ud.setString(2, sc.nextLine());
		   System.out.println("Ngay Sinh: ");
			ud.setString(3, sc.nextLine());
		   System.out.println("Gioi Tinh: ");
			ud.setString(4, sc.nextLine());
		   System.out.println("Ma Khoa: ");
			ud.setString(5, sc.nextLine());
			
		
			 ud.setString(6,masv);
			   ud.executeUpdate();
			   
			   System.out.println("Successful Update!");
		   }
		   else {
			   System.out.println("Not found MASV!");
		       
		   };
		} catch (SQLException e) {
			System.out.println("Cập nhật thất bại!");
			e.printStackTrace();
		}
}
	
//MAIN
	public static void main(String[] args) {
		
			try {
				String Url ="jdbc:sqlserver://ZISUKYA:1433;databaseName=QLSV;integratedSecurity=true;encrypt=false";
				Connection cnn = DriverManager.getConnection(Url);
				System.out.println("Thanh cong!");
					Statement cmd = cnn.createStatement();//Tao lenh truy van thong qua JAVA

					Scanner sc = new Scanner(System.in);//lenh Scanner nhap du lieu vao
					cc cc = new cc();
					 while (true) {
					        System.out.println("|______________________|");
					    	System.out.println("CHOOSE THE BEST WHAT U WANA TO DO: ");
					        System.out.println("1.Output");
					        System.out.println("2.Input");
					        System.out.println("3.Search");
					        System.out.println("4.Delete");
					        System.out.println("5.Update");
			
							int number = sc.nextInt();//chon truy van
				  switch(number) {
					   case 1:
						   cc.out(cmd);
						   			break;
					   case 2: 
						  cc.add(cnn);
						   break;
						   
					   case 3:
						  cc.search(cnn);
						   break;
						   
					   case 4: 
						  cc.delete(cnn);
						   break;
						   
					   case 5:
						  cc.update(cnn);
						   break;
					
						    default: 
						    	System.out.println("Reselect, please!");
							      };//lenh switch-case
				
						 
					 }//vong lap
			} catch (SQLException e) {
				System.out.println("That bai!");
				e.printStackTrace();
			}
}
}

