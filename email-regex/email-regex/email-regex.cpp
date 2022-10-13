/*
8888888b.  8888888888.d8888b.  8888888888 Y88b   d88P      8888888888 888b     d888        d8888 8888888 888
888   Y88b 888       d88P  Y88b 888         Y88b d88P       888        8888b   d8888       d88888   888   888
888    888 888       888    888 888          Y88o88P        888        88888b.d88888      d88P888   888   888
888   d88P 8888888   888        8888888       Y888P         8888888    888Y88888P888     d88P 888   888   888
8888888P"  888       888  88888 888           d888b         888        888 Y888P 888    d88P  888   888   888      
888 T88b   888       888    888 888          d88888b        888        888  Y8P  888   d88P   888   888   888
888  T88b  888       Y88b  d88P 888         d88P Y88b       888        888   "   888  d8888888888   888   888      
888   T88b 8888888888 "Y8888P88 8888888888 d88P   Y88b      8888888888 888       888 d88P     888 8888888 88888888 

-->	https://patorjk.com/software/taag/#p=display&f=Colossal&t=REGEX%20EMAIL colossal	
*/


//Librerias utilizadas
#include <iostream>
#include <regex>
#include <string>

// Simulador regex: https://regexr.com/
// Documentacion regex: https://regexone.com/

using namespace std;

int main()
{
	/* ---VARIABLE--- */
	string email;



	/* El usuario ingresa su correo electronico */
	cout << "Ingresa tu correo electronico institucional: ";
	cin >> email;

	/* Validamos que el correo del usuario sea correcto */
	if (regex_match
	(
		email, 
		regex("^[a-z]+[.]+[a-z]+\d{2}+@unach+[.]+mx$")
		//^[a-z]+\.+[a-z]+\d{2}+@unach+\.+mx$
	))
		cout << "SI Has ingresado correctamente tu correo electronico institucional...\n";

	else 
		cout << "NO has ingresado correctamente tu correo electronico institucional...\n";
	
	cout << endl;
	system("pause");

}
