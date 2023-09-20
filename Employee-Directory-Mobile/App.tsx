import { StatusBar } from 'expo-status-bar';
import React, { useEffect, useState } from 'react';
import { Button, SafeAreaView, ScrollView, StyleSheet, Text, View } from 'react-native';
import { EmployeeType } from './Types/EmployeeType';
import EmployeeCard from './components/EmployeeCard';




export default function App() {
  const [employees, setEmployees] = useState(Array<EmployeeType>());


  useEffect(() => {
    fetch('https://f9f0-174-101-131-39.ngrok-free.app/api/employee')
    .then(response => response.json())
    .then(employees => {
      console.log(employees);
      setEmployees(employees);
    })
    .catch(error => {
      console.error(error);
    });

    
  });

  return (
    <SafeAreaView style={styles.container}>
      <ScrollView style={styles.listView}>
        {employees.map((employee) => (
            <EmployeeCard key={employee.Id}  employee={employee}  />
        ))}
      </ScrollView>

      <StatusBar style="auto" />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    backgroundColor:'#4444'
    },

  listView:{
    width: '90%'
  }
});
