import { View, Text, StyleSheet, Image } from "react-native";
import React from "react";
import { EmployeeType } from "../Types/EmployeeType";

export default function EmployeeCard(props: { employee: EmployeeType }) {
  return (
    <View style={[styles.card, styles.shadowProp]}>
      <Image style={styles.tinyLogo} source={{ uri: props.employee.ImgURL }} />
      <View style={styles.infoView}>
        <Text style={styles.text}>
          {props.employee.Name} - {props.employee.Position}
        </Text>
        <Text style={styles.text}>{props.employee.Department}</Text>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  card: {  
    backgroundColor: 'white',  
    borderRadius: 6,  
    width: '100%',  
    flex: 1,
    flexDirection: "row",
    marginTop: 15,
    padding: 10,
    alignItems: "center",
  },  
  tinyLogo: {
    width: 50,
    height: 50,
  },
  infoView: {
    flex: 1,
    flexDirection: "column",
    alignItems: 'center',
  },
  shadowProp: {  
    shadowOffset: {width: -2, height: 4},  
    shadowColor: '#171717',  
    shadowOpacity: 0.2,  
    shadowRadius: 3,  
  },  
  text:{
    fontWeight:'bold'
  }
});
