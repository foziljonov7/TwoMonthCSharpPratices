using System.Security.Principal;

Client client = new Client();

client.BuildVehicle(VehicleType.TwoWheeler);
client.RetreiveVehicle().PrintVehicleInfo();

client.BuildVehicle(VehicleType.FourWheeler);
client.RetreiveVehicle().PrintVehicleInfo();

client.BuildVehicle(VehicleType.ThreeWheeler);
client.RetreiveVehicle().PrintVehicleInfo();