import * as React from "react";
import "@progress/kendo-theme-default/dist/all.css";
import * as ReactDOM from "react-dom";
import { Grid, GridColumn as Column } from "@progress/kendo-react-grid";
import { EmployeesDataLoader } from "../Data/EmployeeDataLoader";

export function EmployeeGrid() {
    const [employees, setEmployees] = React.useState({
        data: [],
        total: 77,
    });
    const [dataState, setDataState] = React.useState({
        take: 10,
        skip: 0,
    });
    const dataStateChange = (e) => {
        setDataState(e.dataState);
    };
    const dataReceived = (employees) => {
        console.log(employees);
        setEmployees(employees);
    };
    return (
        <div>
            <Grid
                filterable={true}
                sortable={true}
                pageable={true}
                toolbar={false}
                {...dataState}
                data={employees}
                onDataStateChange={dataStateChange}
            >
                <Column field="Name" title="Name" />
                <Column field="Value" filter="numeric" title="Value" />
            </Grid>

            <EmployeesDataLoader dataState={dataState} onDataReceived={dataReceived} />
        </div>
    );
}