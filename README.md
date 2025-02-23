# Weighting-Scale-Using-Loadcell
# Design of Weight Measurement and Display Circuit

## Introduction
This project aims to design a system for measuring and displaying weight using a Load Cell sensor, an ESP32 microcontroller, and a computer interface for calibration.

<p align="center">
  <img src="https://github.com/user-attachments/assets/808895d1-772b-4e61-aa29-bd4501ab2202" alt="Project Overview">
  <br>
  <em>Figure 1: Overview of the Weight Measurement System</em>
</p>

## Main Components

<p align="center">
  <img src="https://github.com/user-attachments/assets/f25f9b06-2054-491b-ae1d-c2526dfa55e6" alt="Project Overview">
  <br>
  <em>Figure 1: Overview of the Weight Measurement System</em>
</p>

- **Load Cell Sensor**: Measures weight by converting force into an electrical signal.
- **Signal Amplifier Circuit**: Amplifies weak signals from the Load Cell, typically using HX711 or a similar amplifier circuit.
- **ESP32**:
  - Reads ADC data from the amplifier circuit.
  - Processes signals and transmits data via Serial.
  - Displays weight on an LCD screen.
- **LCD**: Displays measurement results.
- **Computer Interface (C# - Visual Studio 2022)**: Supports system calibration.

## Working Principle
1. The Load Cell deforms under load → changes strain gauge resistance → alters output voltage.
2. The signal amplifier circuit enhances the signal.
3. ESP32 reads ADC values from the Load Cell via the amplifier circuit.
4. The measured value is displayed on the LCD.
5. The computer can communicate with ESP32 for calibration purposes.

## Installation Guide
### 1. Required Hardware
- Load Cell 5kg or 10kg.
- HX711 signal amplifier circuit or op-amp.
- ESP32 microcontroller.
- LCD 16x2 or OLED display.
- Connecting wires and appropriate power supply.

### 2. ESP32 Programming (Arduino IDE)
- Install **Arduino IDE** and ESP32 libraries.
- Add library support for HX711 if used.
- Write code to read ADC, process signals, and send data via Serial.

### 3. Calibration Interface (C# - Visual Studio)
- Develop a Windows Form application in C# to send calibration parameters to ESP32.
- Establish Serial communication with ESP32 to save and update Zero/Span.

## Calibration Process
### **Step 1: Zero Calibration**
- Place the Load Cell in a no-load condition.
- Read the ADC value and set it as the **Zero** value.
- Adjust the Trackbar to bring the value close to 0.

### **Step 2: Span Calibration**
- Place a known weight (e.g., 1kg) on the Load Cell.
- Read the new ADC value and calculate the scale factor (Kg/V).
- Adjust the Trackbar until the scale displays the correct weight.

## Results
- The system accurately displays weight on the LCD.
- Calibration can be adjusted as needed via the computer interface.

---
Thank you for your interest in the project! 
