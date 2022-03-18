let matching_braces = function(input_string){
    let num_open_braces = 0; //keep track of how many open braces we've encountered

    for(let char of input_string){ //loop through each character of the given string
        if(char === "{"){
            num_open_braces++; //increment the number of open braces that need closing braces
        }
        
        if(char === "}"){
            if(!num_open_braces){ //if we haven't encountered any open braces then we already know we have mismatched braces
                return false;
            }

            num_open_braces--; //decrement the number of open braces that don't have a closing brace
        }
    }

    return !num_open_braces; //if the number of open braces is 0 return true, otherwise false
}

let unit_test = function(test_inputs_array, test_outputs_array){
    console.log("Start testing...");

    for(let i=0; i<test_inputs_array.length; i++){
        let test_input = test_inputs_array[i];
        let output_actual = test_outputs_array[i];
        let output = matching_braces(test_input);

        if(output != output_actual){
            console.log(`For the string '${test_input}' the output '${output}' was given. The expexted output was '${output_actual}'.`);
        }
    }

    console.log("End testing...");
}

let test_inputs_array =  ["{}", "}{", "{{}", "", "{abc...xyz}"];
let test_outputs_array = [true, false, false, true, true];
unit_test(test_inputs_array, test_outputs_array);