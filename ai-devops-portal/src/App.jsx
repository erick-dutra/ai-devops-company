import { useState, useEffect } from 'react'
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom'
import { Sidebar } from '@/components/Sidebar'
import { Header } from '@/components/Header'
import { Dashboard } from '@/components/Dashboard'
import { ProjectManagement } from '@/components/modules/ProjectManagement'
import { Development } from '@/components/modules/Development'
import { QualityAssurance } from '@/components/modules/QualityAssurance'
import { Operations } from '@/components/modules/Operations'
import { DevOps } from '@/components/modules/DevOps'
import { Monitoring } from '@/components/modules/Monitoring'
import { Security } from '@/components/modules/Security'
import { Finance } from '@/components/modules/Finance'
import { HumanResources } from '@/components/modules/HumanResources'
import { Settings } from '@/components/Settings'
import { Login } from '@/components/Login'
import { AuthProvider, useAuth } from '@/contexts/AuthContext'
import { ThemeProvider } from '@/contexts/ThemeContext'
import './App.css'

function AppContent() {
  const { user, loading } = useAuth()
  const [sidebarOpen, setSidebarOpen] = useState(true)

  if (loading) {
    return (
      <div className="flex items-center justify-center min-h-screen">
        <div className="animate-spin rounded-full h-32 w-32 border-b-2 border-primary"></div>
      </div>
    )
  }

  if (!user) {
    return <Login />
  }

  return (
    <div className="flex h-screen bg-background">
      <Sidebar open={sidebarOpen} onToggle={() => setSidebarOpen(!sidebarOpen)} />
      
      <div className="flex-1 flex flex-col overflow-hidden">
        <Header onMenuClick={() => setSidebarOpen(!sidebarOpen)} />
        
        <main className="flex-1 overflow-x-hidden overflow-y-auto bg-background p-6">
          <Routes>
            <Route path="/" element={<Navigate to="/dashboard" replace />} />
            <Route path="/dashboard" element={<Dashboard />} />
            <Route path="/project-management" element={<ProjectManagement />} />
            <Route path="/development" element={<Development />} />
            <Route path="/quality-assurance" element={<QualityAssurance />} />
            <Route path="/operations" element={<Operations />} />
            <Route path="/devops" element={<DevOps />} />
            <Route path="/monitoring" element={<Monitoring />} />
            <Route path="/security" element={<Security />} />
            <Route path="/finance" element={<Finance />} />
            <Route path="/human-resources" element={<HumanResources />} />
            <Route path="/settings" element={<Settings />} />
          </Routes>
        </main>
      </div>
    </div>
  )
}

function App() {
  return (
    <ThemeProvider>
      <AuthProvider>
        <Router>
          <AppContent />
        </Router>
      </AuthProvider>
    </ThemeProvider>
  )
}

export default App

