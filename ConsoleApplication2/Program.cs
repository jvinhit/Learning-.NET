using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static Object StudentAtras = null;
public static final Object StudentAtras(int id, String name, String address, String email,
int age, int salary) {
return StudentAtras;
}
ArrayList<StudentAtras> arr = new ArrayList<StudentAtras>();
public void nhapdl(){
newFile();
arr.add(new StudentAtras(id,name,address,email,age,salary));
}
public void openFile() throws IOException{
try { // dat try cacth de tranh ngoai le khi tao va ghi File
FileOutputStream f = new FileOutputStream("D:\\student.dat"); // tao file f tro den student.dat
ObjectOutputStream oStream = new ObjectOutputStream(f); // dung de ghi theo Object vao file f
oStream.writeObject(StudentAtras); // ghi student theo kieu Object vao file
oStream.close();
System.out.println("ghi thanh cong");
} catch (IOException e) {
System.out.println("ghi file that bai");
}
try { // dat try cacth de tranh ngoai le khi tao va doc File
FileInputStream f = new FileInputStream("D:\\student.dat"); // tao file f tro den student.dat
ObjectInputStream inStream = new ObjectInputStream(f); // dung de doc theo Object vao file f
// dung inStream doc theo Object, ep kieu tra ve la Student
try {
StudentAtras = inStream.readObject();
} catch (ClassNotFoundException e) {
// TODO Auto-generated catch block
e.printStackTrace();
}
inStream.close();
} catch (IOException e) {
System.out.println("Error Read file");
}
try {
for (int i = 0;i<arr.size(); i++) {
arr.get(i).openFile();
}
} catch (NullPointerException e) {
System.out.println("File Empty");
}
    }
}
