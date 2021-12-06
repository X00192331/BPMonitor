Feature: Calculator

Scenario: Low Blood Pressure
	Given the Systolic number is 89
	And the Diastolic number is 50
	When the BPCategory is calculated
	Then the result should be Low

Scenario: Ideal Blood Pressure
	Given the Systolic number is 90
	And the Diastolic number is 50
	When the BPCategory is calculated
	Then the result should be Ideal


Scenario: PreHigh Blood Pressure
	Given the Systolic number is 130
	And the Diastolic number is 80
	When the BPCategory is calculated
	Then the result should be PreHigh

Scenario: High Blood Pressure
	Given the Systolic number is 170
	And the Diastolic number is 80
	When the BPCategory is calculated
	Then the result should be High