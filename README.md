# Weighting-Scale-Using-Loadcell
# Design of Weight Measurement and Display Circuit

<p align="center">
  <img src="https://github.com/user-attachments/assets/f25f9b06-2054-491b-ae1d-c2526dfa55e6" alt="Project Overview">
  <br>
  <em>Figure 1:The Weight Measurement System</em>
</p>


## Introduction
This project aims to design a system for measuring and displaying weight using a Load Cell sensor, an ESP32 microcontroller, and a computer interface for calibration.

<p align="center">
  <img src="https://github.com/user-attachments/assets/808895d1-772b-4e61-aa29-bd4501ab2202" alt="Project Overview">
  <br>
  <em>Figure 2: Overview of the Weight Measurement System</em>
</p>

## Main Components

<p align="center">
  <img src="https://github.com/user-attachments/assets/6e83fd00-9cf5-44c0-8f57-35fa005a5076" alt="Project Overview">
  <br>
  <em>Figure 3: Main Components of the Weight Measurement System</em>
</p>

- **Load Cell Sensor**: Measures weight by converting force into an electrical signal.
- **Signal Amplifier Circuit**: Amplifies weak signals from the Load Cell, typically using HX711 or a similar amplifier circuit.
- **ESP32**:
  - Reads ADC data from the amplifier circuit.
  - Processes signals and transmits data via Serial.
  - Displays weight on an LCD screen.
- **LCD**: Displays measurement results.
- **Computer Interface (C# - Visual Studio 2022)**: Supports system calibration.

<p align="center">
  <img src="https://github.com/user-attachments/assets/53a80578-5550-4379-8c9d-3fb1479bbe52" alt="Project Overview">
  <br>
  <em>Figure 4: The connection all components of the Weight Measurement System</em>
</p>

## Working Principle
## 1. **Load Cell Deformation**
### Working Principle of a Load Cell (Force Sensor)
A **load cell** is a force sensor that measures weight or force by converting mechanical deformation into an electrical signal. This process is achieved using **strain gauges**, which are attached to a deformable structure within the load cell. When a force is applied, the strain gauges experience either **tension** or **compression**, causing a change in their electrical resistance. 

<p align="center">
  <img src="https://github.com/user-attachments/assets/d0d82707-c9fb-4d37-bb55-cc8dee7126a9" alt="Project Overview">
  <br>
  <em>Figure 5: Load Cell </em>
</p>

### Strain Gauge Deformation
- When the load cell is subjected to force:
  - **Tension** in the strain gauge → **Resistance Increases**
  - **Compression** in the strain gauge → **Resistance Decreases**

- The change in resistance is proportional to the applied force, allowing accurate force measurement.

<p align="center">
  <img src="https://github.com/user-attachments/assets/5e720e9f-9ae2-411b-8e77-cb7f5606270d" alt="Project Overview">
  <br>
  <em>Figure 6: Strain Gauge Deformation </em>
</p>

### Wheatstone Bridge Circuit

<p align="center">
  <img src="https://github.com/user-attachments/assets/227e8539-ac7e-4b6f-ae8b-8c84b602499f" alt="Project Overview">
  <br>
  <em>Figure 7: Wheatstone Bridge Circuit </em>
</p>

Strain gauges are connected in a **Wheatstone Bridge** configuration, which translates the small resistance changes into a measurable voltage output:

```
V_out = V_exc × (ΔR / R)
```

Where:
- `V_out` = Output voltage of the Wheatstone Bridge
- `V_exc` = Excitation voltage supplied to the bridge 
- `R` = Initial resistance of the strain gauge
- `ΔR` = Change in resistance due to strain

## 2. Signal Amplification
Since the output voltage from the Wheatstone Bridge is in the millivolt range, an **amplifier** (e.g., HX711) is used to increase the signal strength before it is processed by a microcontroller.

### Digital Processing and Calibration
1. The amplified voltage is converted to a digital signal using an ADC (Analog-to-Digital Converter).
2. The microcontroller applies a **calibration factor** to determine the actual force or weight.
3. The final measurement is displayed on an LCD screen or transmitted to a computer.

### Summary
- A force applied to the load cell deforms the strain gauges.
- The strain gauges change resistance based on **tension** or **compression**.
- The **Wheatstone Bridge Circuit** converts resistance changes into a voltage signal.
- The signal is **amplified and digitized** for processing.
- The microcontroller applies a **calibration factor** to calculate weight/force.
- The final value is displayed or logged for further use.

## 2. **Wheatstone Bridge Circuit**
Strain gauges are typically connected in a **Wheatstone Bridge** circuit, which converts small resistance changes into a measurable voltage signal.

The basic formula for the Wheatstone Bridge is:

```
V_out = V_exc × (ΔR / R)
```

Where:
- `V_out` is the output voltage of the Wheatstone Bridge.
- `V_exc` is the excitation voltage supplied to the bridge (typically 5V to 10V).
- `R` is the initial resistance of the strain gauge.
- `ΔR` is the change in resistance due to deformation.

Since this voltage change is very small, it requires amplification to be accurately measured.

## 3. Signal Amplification
To amplify the small voltage change from the Wheatstone Bridge, we use a three-op-amp instrumentation amplifier circuit instead of the HX711 module.

### Instrumentation Amplifier Circuit
The amplification stage consists of:
- Two buffer amplifiers (A1, A2) using **IC UA741** for high input impedance.
- A subtractor stage (A3) to amplify the differential signal.
- Resistors \( R \) and \( R_G \) determine the gain of the amplifier.

The output voltage is given by:

```
V_OUT = - (V_IN+ - V_IN-) x (1 + 2R/R_G)
```

<p align="center">
  <img src="https://github.com/user-attachments/assets/398ff775-52f5-4142-bd80-d05916ad2d95" alt="Project Overview">
  <br>
  <em>Figure 8: Signal amplifier circuit </em>
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/3e641c9f-b84e-41b0-822e-e4e064f52717" alt="Project Overview">
  <br>
  <em>Figure 9: Simulating Signal amplifier circuit in Proteus </em>
</p>

This design provides high precision and stability for force measurement applications.

## 4. **Digital Signal Processing and Calibration**
After receiving data from the Amplifier Circuit, the microcontroller performs the following steps:

1. **Convert the ADC signal to actual weight** using a linear equation:

```
W = k × V_out
```

Where:
- `W` is the weight in kilograms.
- `k` is the calibration factor (determined during the calibration process).
- `V_out` is the output voltage from the Wheatstone Bridge.

2. **Calibration process**:
   - **Zero calibration**: Setting the initial weight to zero when no load is applied.
```c
  if(command == "CZERO"){
    blinkledandplaybuzzer();
    int address = 0;
    EEPROM.writeDouble(address, zerotime);
    EEPROM.commit();
    zerotime = data.toDouble();
    zero = zerotime;
  }
```
   - **Span calibration**: Using a known weight to determine the scaling factor.
```c
  if(command == "CSPAN"){
    blinkledandplaybuzzer();
    int address = 8;
    EEPROM.writeDouble(address, spantime);
    EEPROM.commit();
    spantime = data.toDouble();
    span = spantime;
  }
```
The calibration factor can be calculated using:

```
k = W_calibration / V_out_calibration
```

Where `W_calibration` is the known weight used for calibration.

To ensure accurate weight measurement, a calibration process is performed using software on both the microcontroller and the PC.

#### Communication
- **C (Arduino IDE):** Reads and decodes the ADC values from the amplifier circuit, then sends the data to the PC via the Serial COM port.
- **C# (Visual Studio 2022):** Provides a calibration interface and sends calibration parameters to the ESP32, which stores them in EEPROM for later use.

#### 1. **Arduino IDE**
- Develop a program to read and decode the ADC values from the amplifier circuit.
- Transmit the data through the Serial COM port to a connected laptop.

#### 2. **Visual Studio**
- Create a graphical calibration interface.
- Send calibration parameters to the ESP32 for storage in EEPROM, ensuring they persist after power cycles.

<br>
<p align="center">
  <img src="https://github.com/user-attachments/assets/ec60efac-fe86-4cc5-b2a7-98d1209f9b4d" alt="Project Overview">
  <br>
  <em>Figure 10: The Winform used to display the weight of item and calibrate </em>
</p>

## 5. **Noise Filtering for Load Cell Signal Stabilization**
To stabilize the signal from the load cell and reduce noise, we apply a **second-order IIR low-pass filter**.

### **Complete IIR Low-Pass Filter Code**
```c
#define ALPHA 0.854  // Filter coefficient; higher values smooth the signal more but slow response
#define BETA  0.0728 // Weight coefficient for the new signal

double weightFilt = 0;      // Filtered output value
double weightfiltPre = 0;   // Previous input signal value

void filterLoadCell() {
    double reading = analogRead(LOADCELL_DOUT_PIN); // Read the ADC signal from the Load Cell
    
    // Apply the second-order IIR low-pass filter
    weightFilt = ALPHA * weightFilt + BETA * reading + BETA * weightfiltPre;

    // Update previous input value
    weightfiltPre = reading;

    // Print raw and filtered values to Serial Monitor for debugging
    Serial.print("Raw: "); Serial.print(reading);
    Serial.print(" | Filtered: "); Serial.println(weightFilt);
}
```
It is shown in the program as follows:
```c
    double reading = analogRead(LOADCELL_DOUT_PIN);
    weightFilt = 0.854*weightFilt + 0.0728*reading + 0.0728*weightfiltPre;
    weightfiltPre = reading;
    Serial.println(weightFilt);
```
### **Noise Filtering Process**

1. **Reads the ADC signal** from the load cell.  
2. **Applies a second-order IIR low-pass filter**:  
   - **ALPHA (0.854):** Retains most of the previous value to smooth the signal.  
   - **BETA (0.0728):** Balances new readings to avoid excessive delay.  
3. **Filtering formula**:  
```
   weightFilt = ALPHA × weightFilt + BETA × reading + BETA × weightfiltPre
```
4. **Stores the new input value** in `weightfiltPre` for the next filtering cycle.  
5. **Outputs both raw and filtered values** to the Serial Monitor for real-time monitoring.  

<br>
<p align="center">
  <img src="https://github.com/user-attachments/assets/1abc02fe-99d2-4a12-abc8-17f2521b3f0a" alt="Project Overview">
  <br>
  <em>Figure 11: The result ADC signal affer using the filter </em>
</p>


## **How to calibrate the weighting scale ?**
## **Calibration Guide: Setting Zero (Zero Calibration)**  

### **1. Determine Initial Weight**  
- Initially, only the **mica plate weight** is present on the Load Cell, with no additional objects.  
- When reading the ADC value from the amplifier circuit, the output is approximately **1360.00**.  

### **2. Set Zero Before Calibration**  
- Before starting the **Zero Calibration**, we need to set an initial reference for the Trackbar.  
- Thus, we set **Zero = 13640** as the calibration baseline.  
- This helps to fine-tune and minimize errors during calibration.  

### **3. Implementing Zero in the Program**  
In the program, the Zero value is calculated as follows:  
```cpp
double valueADC = double.Parse(AllData);  // Convert ADC reading to a double value
zero = calibzero * 1360 / 500;  // Set Zero based on the ADC reading
Span = 1;  // No scale factor between weight and voltage yet
```
**Explanation of Variables**  
- **valueADC**: Converts ADC data into a floating-point number.  
- **zero**: Computed based on the ADC reading and interpolation factor.  
- **Span = 1**: No weight-to-voltage ratio is applied yet.  
 
 ### **4. Adjusting the Trackbar to Complete Zero Calibration**
- Use the Trackbar to adjust the Zero value.  
- Increase or decrease the Zero value until Zero - ADC(0) is as close to 0 as possible.  
- When the value approaches 0, it means the system correctly identifies the no-load state.  

<br>
<p align="center">
  <img src="https://github.com/user-attachments/assets/10dd2c25-9b2f-4ced-a421-c65dd2acb78b" alt="Project Overview">
  <br>
  <em>Figure 12: Set Zero Before Calibration </em>
</p>

## **Calibration Guide: Setting Span (Span Calibration)**  

### **1. Determine the Known Weight for Calibration**  
- A **known weight (1kg)** is placed on the Load Cell.  
- The ADC reading at this point is approximately **1870**.  
- Comparing this with the **Zero Calibration point**, the ratio between **Kg and voltage** is estimated as **510**.  
- The default **Span** value is set to **510** for calibration purposes.  

### **2. Implementing Span in the Program**  
To set the **Span** value in the program, use the following formula:  

```cpp
span = calibspan * 510 / 500;  // Set Span based on ADC reading
weight = (valueADC - zero) / span;  // Calculate weight from ADC value
weightprint = Math.Round(weight, 3);  // Round the weight value to 3 decimal places
```
### **3. Adjusting the Trackbar to Complete Span Calibration**
- Use the Trackbar to fine-tune the Span value.  
- Adjust Span until the displayed weight in the TextBox (ReceiveData) matches the known - weight (1kg).  
- This ensures that the system correctly scales the Load Cell output to actual weight.  
### **4. Send Calibration Parameters to ESP32**  
- Once Zero Calibration and Span Calibration are completed, send both parameters (Zero, - Span) to the ESP32 microcontroller.  
- This allows the ESP32 to accurately measure and process weight readings based on the calibrated values.  

## **Result**

<br>
<p align="center">
  <img src="https://github.com/user-attachments/assets/4eb1b1cc-3577-4c0f-89e9-767f2e62d3cc" alt="Project Overview">
  <br>
  <em>Figure 13: Calibration and display the value weight of item </em>
</p>

<br>
<p align="center">
  <img src="https://github.com/user-attachments/assets/1adcbd3c-26b8-47b8-9a2d-1c8953e25153" alt="Project Overview">
  <br>
  <em>Figure 14: Set the 0.5kg item to test after calibration  </em>
</p>


### **Observations from the Experiment** 
- The PC interface displays a measured weight of **0.499 kg**.  
- The LCD screen shows a weight of **0.50 Gam (gram)**.  
- Both values are very close, indicating that the system operates accurately.  

### **Accuracy and Precision**  
- The small difference (0.499 kg vs. 0.50 kg) may be due to rounding during display formatting.  
- The calibration process was performed using **Zero Calibration and Span Calibration**, ensuring reliable measurement results.  
- No noticeable drift or fluctuation was observed, demonstrating a stable system.