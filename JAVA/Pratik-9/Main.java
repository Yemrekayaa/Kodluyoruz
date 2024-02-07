import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        String username, password, registeredUserName = "patika", registeredPassword = "123456";

        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.print("Kullanıcı Adınızı Giriniz: ");
            username = scanner.next();
            System.out.print("Şifrenizi Giriniz: ");
            password = scanner.next();

            if (username.equals(registeredUserName)) {
                if (password.equals(registeredPassword)) {
                    System.out.println("Başarıyla giriş yaptınız!");
                    break;
                } else {
                    System.out.print("Girdiğiniz şifre yanlış. Şifrenizi sıfırlamak ister misiniz? (Y/N): ");
                    if (scanner.next().equals("Y")) {
                        System.out.print("Lütfen yeni şifrenizi giriniz: ");
                        password = scanner.next();
                        if (password.equals(registeredPassword)) {
                            System.out.println("Şifre oluşturulamadı, lütfen başka şifre giriniz.");
                        } else {
                            registeredPassword = password;
                            System.out.println("Şifre oluşturuldu!");
                        }
                    }
                }
            } else {
                System.out.println("Kullanıcı bulunamadı lütfen geçerli bir kullanıcı adı giriniz!");
            }
        }
    }
}