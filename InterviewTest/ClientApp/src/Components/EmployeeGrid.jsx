import { Grid, GridColumn as Column } from "@progress/kendo-react-grid";
import "@progress/kendo-theme-default/dist/all.css";
import * as React from "react";
import { EmployeesDataLoader } from "../Data/EmployeeDataLoader";

export function EmployeeGrid() {
    const [employees, setEmployees] = React.useState({
        data: [],
        total: 0,
    });

    const [dataState, setDataState] = React.useState({
        take: 10,
        skip: 0,
    });

    return (
        <div>
            <Grid
                filterable={true}
                sortable={true}
                pageable={true}
                toolbar={false}
                {...dataState}
                data={employees}
                onDataStateChange={(e) => setDataState(e.dataState)}
            >

                <Column field="Name" title="Name" />
                <Column field="Value" filter="numeric" title="Value" />

            </Grid>

            <EmployeesDataLoader dataState={dataState} onDataReceived={(employees) => setEmployees(employees)} />
        </div>
    );
}